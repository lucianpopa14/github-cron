using System.Text;

int commits = 1;
string file = "README.md";
bool dryRun = false;
const string marker = "<!-- HEARTBEAT -->";

for (int i = 0; i < args.Length; i++)
{
    switch (args[i])
    {
        case "--commits":
            if (i + 1 < args.Length && int.TryParse(args[i + 1], out var c))
            {
                commits = Math.Max(1, c);
                i++;
            }
            break;
        case "--file":
            if (i + 1 < args.Length)
            {
                file = args[i + 1];
                i++;
            }
            break;
        case "--dry-run":
            dryRun = true;
            break;
    }
}
if (!File.Exists(file))
{
    Console.WriteLine($"File '{file}' not found. Creating it.");
    File.WriteAllText(file, "# README\n\n", new UTF8Encoding(false));
}

for (int i = 0; i < commits; i++)
{
    var stamp = $"Heartbeat: {DateTime.UtcNow:dd-MM-yyyy HH:mm:ss}UTC #{i+1} ({Guid.NewGuid().ToString()[..8]})";
    var heartbeatLine = $"{marker} {stamp}";
    var lines = File.ReadAllLines(file).ToList();
    var idx = lines.FindIndex(l => l.Contains(marker));
    if (idx >= 0) lines[idx] = heartbeatLine;
    else lines.Add(heartbeatLine);
    if (dryRun) Console.WriteLine($"[DryRun] Would write: {heartbeatLine}");
    else File.WriteAllLines(file, lines, new UTF8Encoding(false));
    Thread.Sleep(800);
}

Console.WriteLine($"Done. Updated '{file}' {(dryRun ? "(dry-run)" : "")}.");