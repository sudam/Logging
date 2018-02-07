**Writing logs into a file using Log4Net Library, specially on Exception handling in .NET programs**

**Configure Log4Net in Visual Studio Console App**

1. Add this code line to AssemblyInfo.cs

`[assembly: log4net.Config.XmlConfigurator(Watch = true)]`

2. Adding Configuration for Log4Net right before the <startup></startup> tags.

```c#
<configSections>
  <section name="log4net" type="log4net.Config.Log4NetConfigurationSectionHandler,Log4net"/>
</configSections>
```
```c#
<log4net>
  <appender name="DemoAppender" type="log4net.Appender.RollingFileAppender" >
    <file value="D:\Log\logging.log" />
    <encoding value="utf-8" />
    <appendToFile value="true" />
    <rollingStyle value="Date" />
    <!--<rollingStyle value="Size" />
    <maxSizeRollBackups value="5" />
    <maximumFileSize value="5MB" />
    <staticLogFileName value="true" />-->
    <layout type="log4net.Layout.PatternLayout">
      <conversionPattern value="%date - %type.%method - %message%n" />
    </layout>
  </appender>
  <root>
    <level value="All" />
    <appender-ref ref="DemoAppender" />
  </root>
</log4net>
```
 3. Run the Program



Simple as that!
