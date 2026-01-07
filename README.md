# GitHub Cron

A .NET 10 script for creating periodic heartbeat commits in your README.

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

## Script Format

This project uses .NET's top-level script format (`.csx`) which:
- ✅ Requires no project files (.csproj/.sln)
- ✅ Runs directly with `dotnet script`
- ✅ Supports command-line arguments
- ✅ Is easier to version control


<!-- HEARTBEAT --> Heartbeat: 07-01-2026 04:35:26UTC #1 (fb38a46f)
