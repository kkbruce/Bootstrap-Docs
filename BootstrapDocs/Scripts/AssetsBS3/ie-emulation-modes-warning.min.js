/*!
 * Copyright 2014 Twitter, Inc.
 *
 * Licensed under the Creative Commons Attribution 3.0 Unported License. For
 * details, see http://creativecommons.org/licenses/by/3.0/.
 */
(function(){"use strict";function r(){var n=/MSIE ([0-9.]+)/.exec(window.navigator.userAgent),t,i;return n===null?null:(t=parseInt(n[1],10),i=Math.floor(t),i)}function u(){var n=new Function("/*@cc_on return @_jscript_version; @*/")();return n===undefined?11:n<9?8:n}var i=window.navigator.userAgent,n,t;i.indexOf("Opera")>-1||i.indexOf("Presto")>-1||(n=r(),n!==null)&&(t=u(),n!==t&&window.alert("WARNING: You appear to be using IE"+t+" in IE"+n+" emulation mode.\nIE emulation modes can behave significantly differently from ACTUAL older versions of IE.\nPLEASE DON'T FILE BOOTSTRAP BUGS based on testing in IE emulation modes!"))})();
//# sourceMappingURL=ie-emulation-modes-warning.min.js.map
