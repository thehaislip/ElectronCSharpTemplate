# ElectronCSharpTemplate
dotnet restore

// publish for windows

dotnet publish -r win10-x64 --output bin/dist/win

// publish for macos

dotnet publish -r osx.10.11-x64 --output bin/dist/osx

npm install

npm start

npm run dist
