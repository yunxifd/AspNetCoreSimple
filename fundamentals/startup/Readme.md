
Startup类

## 参考资料
[使用IStartupFilter注册中间件]https://www.cnblogs.com/artech/p/asp-net-core-real-pipeline-05.html  

在Startup类中，在`ConfigureServices方法中使用 IStartupFilter` 与在 `Configure方法中使用UseMiddleware`注册中间件的唯一区别：  
IStartupFilter注册的中间件会先执行  

> 官方文档上说 `IStartupFilter` 有助于确保中间件在应用请求处理管道的开始或结束时由库添加的中间件之前或之后运行。
> 不知道怎么确保在处理管道请求之后运行？