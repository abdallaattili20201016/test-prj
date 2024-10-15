var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.test_prj_ApiService>("apiservice");

builder.AddProject<Projects.test_prj_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(apiService);

builder.Build().Run();
