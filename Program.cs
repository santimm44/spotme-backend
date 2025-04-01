using service;
using spotme_backend.model;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Custom added scopes
builder.Services.AddScoped<UserService>();

builder.Services.AddCors(options =>{
    options.AddPolicy("AllowAll",
    policy=>{
        policy.AllowAnyHeader()
        .AllowAnyMethod()
        .AllowAnyOrigin();
    }
    );
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

//Call AllowAll
app.UseCors("AllowAll");

app.UseAuthorization();

app.MapControllers();

app.Run();
