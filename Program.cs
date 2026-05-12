builder.Services.AddTransient<LocalStorageProvider>();
builder.Services.AddTransient<AzureBlobStorageProvider>();
builder.Services.AddTransient<Func<string, IStorageProvider>>(sp => key =>
{
    return key switch
    {
        "azure" => sp.GetRequiredService<AzureBlobStorageProvider>(),
        _ => sp.GetRequiredService<LocalStorageProvider>()
    };
});