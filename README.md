# CSharpRestful API

一个C# RESTful API项目，使用ASP.NET Core 2.2 构建，使用Swagger生成API文档。


# 启动项目

## 1. 安装NuGet包
```bash
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Microsoft.EntityFrameworkCore.Tools
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet add package Microsoft.EntityFrameworkCore.Proxies
dotnet add package Microsoft.AspNetCore.App
dotnet add package Microsoft.AspNetCore.Razor.Design
dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design
dotnet add package Microsoft.EntityFrameworkCore.Sqlite
```

## 2. 创建数据库
```bash
dotnet ef migrations add InitialCreate
dotnet ef database update
```

## 3. 启动项目
```bash
dotnet run
dotnet watch run
```

## 4. 访问API
### 4.1 获取API文档
```bash
```

### 4.2 获取所有用户
```bash
```
### 4.3 获取单个用户

### 4.4 创建用户

### 4.5 更新用户

### 4.6 删除用户

### 4.7 获取所有角色

### 4.8 获取单个角色

### 4.9 创建角色

### 4.10 更新角色

### 4.11 删除角色

### 4.12 获取所有权限

### 4.13 获取单个权限

### 4.14 创建权限

### 4.15 更新权限


## 5. 项目结构

### 5.1 项目目录文件

### 5.2 Controllers文件夹

### 5.3 appsettings.Development.json

### 5.4 obj文件夹

### 5.5 Properties launchSettings

### 5.6 Program.cs

### 5.7 CSharpRestfulAPI.sln

### 5.8 CSharpRestfulAPI.csproj

### 5.9 路由分组

## 5.10 文件上传

## 5.11 文件下载


### 5.2 项目依赖


```
```


### 5.3 项目配置

#### 5.3.1 配置文件

#### 5.3.2 数据库配置

#### 5.3.3 Redis缓存配置

#### 5.3.4 邮件配置

#### 5.3.5 配置Swagger

#### 5.3.6 配置日志

#### 5.3.7 配置JWT

#### 5.3.8 配置允许跨域

#### 5.3.9 开发环境、生产环境URL





# swagger
```bash
dotnet watch run
```

>http://localhost:5029/swagger/index.html