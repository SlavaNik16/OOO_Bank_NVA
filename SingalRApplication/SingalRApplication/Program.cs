using SingalRApplication.Hubs;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSignalR();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.UseDeveloperExceptionPage();

app.UseDefaultFiles();
app.UseStaticFiles();

app.UseRouting();

app.UseEndpoints(endpoints =>
{
    endpoints.MapHub<ChatHub>("/chat");
});

app.MapPost("/upload", async (HttpContext context) =>
{
    // получем коллецию загруженных файлов
    IFormFileCollection files = context.Request.Form.Files;
    // путь к папке, где будут храниться файлы
    var uploadPath = $"{Directory.GetCurrentDirectory()}/uploads";
    // создаем папку для хранения файлов
    Directory.CreateDirectory(uploadPath);

    // пробегаемся по всем файлам
    foreach (var file in files)
    {
        // формируем путь к файлу в папке uploads
        string fullPath = $"{uploadPath}/{file.FileName}";

        // сохраняем файл в папку uploads
        using (var fileStream = new FileStream(fullPath, FileMode.Create))
        {
            await file.CopyToAsync(fileStream);
        }
    }
    await context.Response.WriteAsync("Файлы успешно загружены");
});

app.Run();
