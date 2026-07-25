# 串口调试工具 (CShapeSerialPort)

一个基于 C# WinForms 的轻量级串口调试工具，支持串口参数配置、HEX 收发、定时发送等功能。适合嵌入式开发、工业设备调试、串口通信协议测试等场景。

## 功能特性

- **串口参数配置**：端口号、波特率（75 ~ 256000 共 19 档）、数据位（5/6/7/8）、校验位（None/Odd/Even/Mark/Space）、停止位（None/One/Two/OnePointFive）
- **HEX 模式**：以十六进制格式发送和接收数据
- **定时发送**：可配置发送间隔（毫秒），自动循环发送
- **实时串口扫描**：启动时自动检测可用 COM 口
- **参数热切换**：串口打开状态下修改参数自动重连，关闭状态下不会误触发打开
- **跨线程安全**：接收数据和错误回调均通过 `BeginInvoke` 回到 UI 线程，避免跨线程异常

## 界面说明

```
<img width="631" height="645" alt="image" src="https://github.com/user-attachments/assets/798c7797-2506-4067-a968-c16871f59ab5" />

```

- **左侧上方**：接收区，实时显示串口收到的数据
- **左侧下方**：发送区，输入要发送的数据后点击"串口发送"
- **右侧**：参数配置面板 + 操作按钮 + 模式选项

## 技术栈

| 项目 | 说明 |
|------|------|
| 框架 | .NET 9 |
| UI | Windows Forms |
| 串口库 | `System.IO.Ports` 8.0.0 (NuGet) |
| 平台 | x64 (Windows) |
| 编码 | GB2312 (936)，兼容串口中文数据 |

## 项目结构

```
SerialPort/
├── CShapeSerialPort.sln        # VS 解决方案
├── CShapeSerialPort.csproj     # .NET 9 SDK 风格项目文件
├── Program.cs                  # 程序入口，注册 GB2312 编码
├── MainFrom.cs                 # 主窗体逻辑（串口开关、收发、定时发送）
├── MainFrom.Designer.cs        # 主窗体 UI 布局（设计器生成）
├── MainFrom.resx               # 窗体资源（图标等）
├── SerialPortUtil.cs           # 串口操作封装类
├── 1_vspdconfig.ico            # 应用图标
└── .gitignore
```

### SerialPortUtil 核心类

`SerialPortUtil` 封装了 `System.IO.Ports.SerialPort`，提供以下能力：

| 方法/属性 | 说明 |
|-----------|------|
| `OpenPort()` | 打开串口（自动设置已配置的参数） |
| `ClosePort()` | 关闭串口 |
| `IsOpen` | 获取串口是否已打开 |
| `WriteData(string)` | 发送字符串 |
| `WriteData(byte[])` | 发送字节数组 |
| `WriteData(byte[], int, int)` | 发送字节数组（带偏移和长度） |
| `SendCommand(byte[], ref byte[], int)` | 同步发送命令并等待响应（可设超时重试次数） |
| `HexToByte(string)` | 十六进制字符串 → 字节数组 |
| `ByteToHex(byte[])` | 字节数组 → 十六进制字符串 |
| `DataReceived` 事件 | 数据接收回调（传出 `byte[]`） |
| `Error` 事件 | 串口错误回调 |
| `SetPortNameValues()` | 静态方法，填充端口号下拉列表 |
| `SetBauRateValues()` | 静态方法，填充波特率下拉列表 |
| `SetDataBitsValues()` | 静态方法，填充数据位下拉列表 |
| `SetParityValues()` | 静态方法，填充校验位下拉列表 |
| `SetStopBitValues()` | 静态方法，填充停止位下拉列表 |

## 快速开始

### 方式一：直接使用已编译的 .exe

从 [Releases](../../releases) 下载 `CShapeSerialPort.exe`，双击即可运行。

该 .exe 为**自包含单文件**，内嵌完整 .NET 9 运行时，无需安装任何运行时环境，拷到任何 64 位 Windows 机器上即可使用。

### 方式二：从源码构建

**前置要求：**

- [.NET 9 SDK](https://dotnet.microsoft.com/download/dotnet/9.0)
- Visual Studio 2022（可选，用于可视化编辑窗体）

**构建步骤：**

```bash
# 克隆仓库
git clone https://github.com/LostAndGet/SerialPort.git
cd SerialPort

# 还原依赖并编译
dotnet build -c Release
```

编译产物在 `bin/Release/net9.0-windows/` 目录下。

### 方式三：发布为自包含单文件 .exe

```bash
dotnet publish -c Release -r win-x64 --self-contained true \
  -p:PublishSingleFile=true \
  -p:IncludeNativeLibrariesForSelfExtract=true \
  -p:EnableCompressionInSingleFile=true \
  -p:DebugType=none \
  -p:DebugSymbols=false
```

产物路径：`bin/Release/net9.0-windows/win-x64/publish/CShapeSerialPort.exe`（约 49MB）

> 如需 32 位版本，将 `win-x64` 改为 `win-x86`，并在 csproj 中将 `PlatformTarget` 改为 `x86`。

## 使用方法

1. 连接串口设备（USB 转串口、物理串口等）
2. 启动程序，右侧自动列出检测到的 COM 口
3. 选择正确的串口参数（波特率、数据位、校验位、停止位）
4. 点击 **"打开串口"** 按钮，状态栏显示绿色表示已打开
5. 在发送区输入数据：
   - **HEX 模式**（默认开启）：输入十六进制格式，如 `A0 0B 01`
   - **文本模式**：取消勾选"以16进制发送接收"，输入普通文本
6. 点击 **"串口发送"** 或勾选 **"定时发送"** 设置自动发送间隔
7. 接收区实时显示收到的数据

## 已修复的问题

本项目在原始版本基础上修复了以下问题：

**MainFrom.cs：**
- 定时器逻辑：输入时间不再无条件启用定时器，仅在勾选"定时发送"时启用
- 定时器对象引用：`timer_Elapsed` 中错误引用 `timer1`（未启用的 Forms.Timer）改为 `timer`
- 跨线程安全：`timer_Elapsed` 和 `comPort_Error` 中的 UI 操作通过 `BeginInvoke` 回到 UI 线程
- 定时器停止：取消勾选"定时发送"时正确停止定时器
- 参数变更：ComboBox 参数变更时不再无条件打开串口，仅在之前已打开时才重新打开

**SerialPortUtil.cs：**
- 接收效率：`ReadByte()` 逐字节读取改为 `comPort.Read()` 批量读取
- 空引用保护：`DataReceived` 事件增加 null 检查
- 异常处理：4 处空 `catch` 块改为 `Debug.WriteLine` 输出异常信息
- 命令发送：`SendCommand` 中直接 `comPort.Open()` 改为 `OpenPort()` 确保参数生效

**项目配置：**
- 从 .NET Framework 3.5 迁移到 .NET 9
- csproj 从旧式格式迁移到 SDK 风格
- 编码兼容性：`Encoding.Default` 改为 `Encoding.GetEncoding(936)` 并注册 `CodePagesEncodingProvider`

## License

本项目原始代码版权归LostAndGet所有。
