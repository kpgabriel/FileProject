## File EXE Project

Hello! Welcome to this basic file reader project. In this project, I would like you to experiment with what you have learned and then create an EXE file to use for whatever multipurpose solution you can think of. 

## Building your EXE file

### From VS
1. Right-click on the C# project and click Publish
2. Under `target` select `Folder`
3. Under `Specific target` select `Folder`
4. Leave the default values selected
5. Edit configuration by clicking the icon
6. Under `Deployment-mode` select self-contained
7. Under `Target-runtime` select `win-x64` or whatever operating system architecture you are using
8. Then click `publish`

### From the command line
`dotnet publish --self-contained true -p:PublishSingleFile=true`

Publish to the Task Scheduler in Windows
View Event logs in the Event Viewer
