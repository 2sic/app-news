import { defineConfig } from 'vite';
import { resolve } from 'path';
import { fileURLToPath } from 'url';
import * as sass from 'sass';
import autoprefixer from 'autoprefixer';
import postcss from 'postcss';

const style = process.env.STYLE || 'bs5';
const scssPath = resolve(process.cwd(), `${style}/styles/${style}.scss`);
const scssFiles = new Set();

export default defineConfig({
  root: '.',
  cacheDir: '.vite_cache',

  build: {
    outDir: `${style}/dist`,
    sourcemap: true,
    emptyOutDir: false,
    assetsDir: 'images',

    rollupOptions: {
      input: {
        scripts: resolve(process.cwd(), 'src/ts/index.ts'),
      },
      output: {
        entryFileNames: '[name].min.js',
        chunkFileNames: '[name].min.js',
        assetFileNames: (assetInfo) => {
          if (assetInfo.name?.endsWith('.css')) {
            const name = assetInfo.name.includes('entry') ? 'styles' : assetInfo.name.replace('.css', '');
            return `${name}.min.css`;
          }
          return 'images/[name].[hash][extname]';
        },
      },
    },

    minify: 'esbuild',
    target: 'es2020',
    cssCodeSplit: false,

    watch: {
      usePolling: true,
    },
  },

  resolve: {
    extensions: ['.ts', '.tsx', '.js', '.scss', '.css'],
  },

  plugins: [
    {
      name: 'compile-scss-to-css',

      buildStart() {
        this.addWatchFile(scssPath);
        scssFiles.forEach(file => this.addWatchFile(file));
      },

      async generateBundle(options, bundle) {
        const result = sass.compile(scssPath, {
          sourceMap: true,
          style: 'compressed',
          silenceDeprecations: ['if-function', 'color-functions', 'global-builtin', 'import'],
        });

        result.loadedUrls.forEach(url => {
          if (url.protocol === 'file:') {
            const filePath = fileURLToPath(url);
            scssFiles.add(filePath);
            this.addWatchFile(filePath);
          }
        });

        const postcssResult = await postcss([autoprefixer()]).process(result.css, {
          from: scssPath,
          to: 'styles.min.css',
          map: {
            inline: false,
            annotation: true,
            prev: result.sourceMap ? JSON.stringify(result.sourceMap) : false,
          },
        });

        this.emitFile({ type: 'asset', fileName: 'styles.min.css', source: postcssResult.css });
        if (postcssResult.map) {
          this.emitFile({ type: 'asset', fileName: 'styles.min.css.map', source: postcssResult.map.toString() });
        }
      },
    }
  ],
});
