var JSInteropWithTypeScript;
(function (JSInteropWithTypeScript) {
    var InteropHelper = /** @class */ (function () {
        function InteropHelper() {
        }
        InteropHelper.prototype.dontCallUsWeCallU = function (dotNetObject) {
            var value = Math.floor(Math.random() * 1000);
            dotNetObject.invokeMethodAsync('JSRandomNumber', value);
        };
        ;
        return InteropHelper;
    }());
    function Load() {
        window['interopHelper2'] = new InteropHelper();
    }
    JSInteropWithTypeScript.Load = Load;
})(JSInteropWithTypeScript || (JSInteropWithTypeScript = {}));
JSInteropWithTypeScript.Load();
//# sourceMappingURL=interopHelper.js.map