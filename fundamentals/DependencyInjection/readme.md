# 依赖注入

## 生命周期

- Transient
Transient lifetime services are created each time they're requested.
- Scoped
Scoped lifetime services are created once per request.
- Singleton
在第一次请求时（或者在运行 ConfigureServices 并且使用服务注册指定实例时）创建的。 每个后续请求都使用相同的实例。

运行项目，浏览http://localhost:5000/
第一次请求
```
 Page Model Operation
 Transient
 92963307-ef5c-4c90-99ec-38a1d5b3cd5b
 Scoped
 ba939a31-37f3-4295-8031-1f27cf12e295
 Singleton
 b05950d8-2469-4073-a475-aa1074181d18
 Instance
 00000000-0000-0000-0000-000000000000
 
 OperationService Operations
 Transient
 08bb0f6c-f82b-42c9-b565-7a12fbb0bce9
 Scoped
 ba939a31-37f3-4295-8031-1f27cf12e295
 Singleton
 b05950d8-2469-4073-a475-aa1074181d18
 Instance
 00000000-0000-0000-0000-000000000000
```
第二次请求
```
Page Model Operation
Transient
86b4c8f8-650b-477c-9457-95ab70ee2598
Scoped
b7dce61f-3b1e-43a2-a95a-90ff41e06a84
Singleton
b05950d8-2469-4073-a475-aa1074181d18
Instance
00000000-0000-0000-0000-000000000000

OperationService Operations
Transient
d5277737-ab60-48cc-836c-3ecec507322b
Scoped
b7dce61f-3b1e-43a2-a95a-90ff41e06a84
Singleton
b05950d8-2469-4073-a475-aa1074181d18
Instance
00000000-0000-0000-0000-000000000000
```

通过对比可以发现
- Transient(暂时性)对象始终不同
- Scoped(作用域)对象，在一个请求的作用域范围内是相同对象，但不同请求之间是不同的
- Singleton(单例)对象，总是相同的，不论作用域还是不同请求