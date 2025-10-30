**Creating a minimal API with ASP.NET Core **

✅ Steps:

Open Visual Studio

Click File → Open → Project/Solution

Select your .sln (solution) file.

Wait for Visual Studio to restore all NuGet packages.

Click the “Run” ▶️ (or IIS Express) button at the top.

Your default browser should open and show your ASP.NET app (e.g. https://localhost:5001 or similar).

🟢 Tip: If it doesn’t restore dependencies automatically, run:

dotnet restore

🧩 2. If You’re Using Visual Studio Code
✅ Prerequisites:

.NET SDK

C# extension

Optionally: SQL Server or SQLite if your project needs a database

✅ Steps:

Open VS Code.

Go to File → Open Folder, select your project folder (the one with .csproj).

Open the terminal in VS Code (Ctrl + `).

Run:

dotnet restore
dotnet build
dotnet run


Once it starts, you’ll see something like:

Now listening on: https://localhost:5001


Open that link in your browser.
