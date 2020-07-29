function my_function(message) {
    console.log("from utilities" + message);
}

//javascript 調用C#靜態方法
function dotnetStaticInvocation() {
    DotNet.invokeMethodAsync("BlazorMovies.Client", "GetCurrentCount")
        //then 返回
        .then(result => {
            console.log("count from javascript" + result);
        });
}
//javascript 調用C#實例方法
function dotnetInstanceInvocation(dotnetHelper) {
    dotnetHelper.invokeMethodAsync("IncrementCount");
}

