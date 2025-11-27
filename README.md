# GitHub Cron

A .NET 10 script for creating periodic heartbeat commits in your README.

## Project Structure

```
github-cron/
├── ReadmeCron/
│   ├── heartbeat.csx       # Main script file
│   └── README.md           # Project documentation
├── README.md               # This file
└── .gitignore             # Git ignore rules
```

## Heartbeat Script

A .NET 10 top-level script (`.csx` format) that updates a README file with periodic heartbeat timestamps.

### Usage

```bash
dotnet script ReadmeCron/heartbeat.csx [options]
```

### Options

- `--commits <n>` - Number of commits/heartbeats to create (default: 1)
- `--file <path>` - Path to the README file to update (default: README.md)
- `--dry-run` - Preview changes without writing to disk

### Examples

```bash
# Single heartbeat
dotnet script ReadmeCron/heartbeat.csx

# Multiple heartbeats
dotnet script ReadmeCron/heartbeat.csx --commits 5

# Specify a custom file
dotnet script ReadmeCron/heartbeat.csx --file HEARTBEAT.md

# Dry run
dotnet script ReadmeCron/heartbeat.csx --dry-run
```

## Requirements

- .NET 10 or later

### Setup Instructions

#### Windows (PowerShell)

```powershell
# 1. Install .NET 10
powershell -Command "Invoke-WebRequest -Uri 'https://dot.net/v1/dotnet-install.ps1' -OutFile 'dotnet-install.ps1'; & './dotnet-install.ps1' -Channel 10.0"

# 2. Install dotnet-script tool
dotnet tool install -g dotnet-script

# 3. Your PowerShell profile will automatically configure the environment
# (It's created automatically when you first run the setup above)
```

#### Linux/macOS

```bash
# 1. Install .NET 10
curl https://dot.net/v1/dotnet-install.sh -o dotnet-install.sh
chmod +x dotnet-install.sh
./dotnet-install.sh --channel 10.0

# 2. Add to PATH (add to ~/.bashrc or ~/.zshrc)
export PATH="/path/to/dotnet:$PATH"

# 3. Install dotnet-script tool
dotnet tool install -g dotnet-script
```

## Script Format

This project uses .NET's top-level script format (`.csx`) which:
- ✅ Requires no project files (.csproj/.sln)
- ✅ Runs directly with `dotnet script`
- ✅ Supports command-line arguments
- ✅ Is easier to version control

## Making Scripts Executable (Linux/macOS)

To make the script directly executable:

```bash
chmod +x ReadmeCron/heartbeat.csx
./ReadmeCron/heartbeat.csx [args]
```

<!-- HEARTBEAT --> Heartbeat: 27-11-2025 10:16:18UTC #1 (7ac75ee3)
