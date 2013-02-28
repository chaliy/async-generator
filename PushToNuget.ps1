# NuGet SetApiKey Your-API-Key
nuget pack .\Package\AsyncGenerator.nuspec

gci *.nupkg | %{
	Write-Host Push $_
	nuget push $_
	rm $_
}