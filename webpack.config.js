const path = require('path');
const MiniCssExtractPlugin = require('mini-css-extract-plugin');

module.exports = (env) => {
  return {
    entry: {
      styles: `./${env.style}/styles/${env.style}.scss`,      
      scripts: './src/ts/index.ts',
    },
    output: {
      path: path.resolve(__dirname, `${env.style}/dist`),
      filename: '[name].min.js',
    },
    mode: 'production',
    devtool: 'source-map',
    watch: true,
    stats: {
      warnings: false,
      cachedModules: false,
      groupModulesByCacheStatus: false
    },
    resolve: {
      extensions: ['.ts', '.tsx', '.js', '.scss']
    },
    cache: {
      type: 'filesystem',
      cacheDirectory: path.resolve(__dirname, '.temp_cache'),
      compression: 'gzip',
    },
    plugins: [
      new MiniCssExtractPlugin({
        filename: '[name].min.css',
      }),
    ],
    module: {
      rules: [{
          test: /\.scss$/,
          exclude: /node_modules/,
          use: [
            MiniCssExtractPlugin.loader,
            {
              loader: 'css-loader',
              options: {
                sourceMap: true
              }
            }, {
              loader: 'postcss-loader',
              options: {
                sourceMap: true,
                postcssOptions: { 
                  plugins: [
                    require('autoprefixer')
                  ] 
                }
              }
            }, {
              loader: 'sass-loader',
              options: {
                sourceMap: true
              }
            }
          ],
        },
        {
          test: /\.ts$/,
          exclude: /node_modules/,
          use: {
            loader: 'ts-loader'
          }
        }
      ],
    },
  }
};