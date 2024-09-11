using DrexlerMacaspac_Activity3.Models;

var builder = WebApplication.CreateBuilder(args);

// Equivalent to ConfigureServices:
builder.Services.AddRazorPages();
builder.Services.AddSession(); // Add this line to enable session support

var app = builder.Build();

// Equivalent to Configure:
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}
else
{
    app.UseDeveloperExceptionPage();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthorization();
app.UseSession(); // Add this line to enable session usage

app.MapRazorPages();

app.Run();
