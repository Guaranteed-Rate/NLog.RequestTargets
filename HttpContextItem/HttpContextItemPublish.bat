del *.nupkg
nuget pack .\HttpContextItem.csproj -Prop Platform=AnyCPU -Prop Configuration=Release
nuget push *.nupkg