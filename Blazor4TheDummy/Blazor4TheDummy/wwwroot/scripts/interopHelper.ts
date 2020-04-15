namespace JSInteropWithTypeScript {

    class InteropHelper {
        public dontCallUsWeCallU(dotNetObject: any) {
            const value = Math.floor(Math.random() * 1000);
            dotNetObject.invokeMethodAsync('JSRandomNumber', value);
        };
    }

    export function Load(): void {
        window['interopHelper2'] = new InteropHelper();
    }
}

JSInteropWithTypeScript.Load();