using AutoMapper;
using Sandbox.Data.MappingProfiles;
using Sandbox.DataAccessLayer.Contexts;
using Sandbox.DataAccessLayer.Models;
using Sandbox.Model.Characters;
using Sandbox.Model.Equipment.Enums;
using Sandbox.Model.Equipment.Weapons;

var mapperConfig = new MapperConfiguration(mc =>
{
    mc.AddProfile(new SandboxMappingProfile());
});

IMapper mapper = mapperConfig.CreateMapper();

var spearman = new Spearman(16);
var spear = new Spear((Material)1);
spearman.Spear = spear;

var spearmanDbo = mapper.Map<SpearmanDbo>(spearman);

using var db = new SandboxContext();

// Note: This sample requires the database to be created before running.
Console.WriteLine($"Database path: {db.DbPath}.");

db.Add(spearmanDbo);
db.SaveChanges();