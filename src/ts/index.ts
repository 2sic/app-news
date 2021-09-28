declare let Fancybox: any;

// This is only partial - if you want to see more, see https://fancyapps.com/docs/ui/fancybox/options
interface FancyboxOptions {
  groupAll: boolean;
  Thumbs: {
    autostart: boolean;
  }
  startIndex?: number;
  preload?: number;
  infinite?: boolean;
  autoFocus?: boolean;
}

var winAny = window as any;
winAny.appNews5 ??= {};
winAny.appNews5.activateFancybox ??= activateFancybox;

function activateFancybox({ groupId, options }: { groupId: string, options: FancyboxOptions }) {
  console.log(groupId);
  Fancybox.bind(`[data-app-news5-fancybox="${groupId}"]`, options);
}