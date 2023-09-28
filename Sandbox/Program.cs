using Sandbox.DataAccessLayer.Contexts;
using Sandbox.DataAccessLayer.Models;
using Sandbox.Model.Characters;
using Sandbox.Model.Equipment.Weapons;

var spearman = new Spearman(15);
var spear = new Spear(0);
spearman.Spear = spear;

using var db = new SandboxContext();

// Note: This sample requires the database to be created before running.
Console.WriteLine($"Database path: {db.DbPath}.");

db.Add(new SpearmanDbo());
db.SaveChanges();

Console.ReadLine();