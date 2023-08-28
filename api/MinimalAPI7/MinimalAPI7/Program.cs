using MinimalAPI7.Models;
using MinimalAPI7.Repositories;
using Swashbuckle.AspNetCore.Swagger;
using Microsoft.OpenApi.Models;
using System.Diagnostics;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();


app.MapGet("/get-all-posts", async () =>
{
    PostRepository _repository = new PostRepository();
    List<Post> result = await _repository.GetPostsAsync();

    if(result == null)
    {
        return Results.BadRequest();
    }

    return Results.Ok(result);
})
.WithName("GetAllPosts")
.WithTags("Post Endpoints")
.WithOpenApi();

app.MapPost("/create-post", async(Post post)=>
{
    PostRepository _repository = new PostRepository();
    bool result = await _repository.CreatePostAsync(post);

    if(!result)
    {
        return Results.BadRequest();
    }

    return Results.Ok("Post Criado com sucesso!");
})
.WithTags("Post Endpoints")
.WithOpenApi();

app.MapGet("/get-post-by-id/{Id}", async(int Id) =>
{
    PostRepository _repository = new PostRepository();

    Post result = await _repository.GetPostByIdAsync(Id);

    if (result == null)
    {
        return Results.BadRequest();
    }

    return Results.Ok(result);
})
.WithTags("Post Endpoints")
.WithOpenApi();

app.MapPut("/update-post", async (Post post) =>
{
    PostRepository _repository = new PostRepository();

    bool updated = await _repository.UpdatePostAsync(post);

    if (!updated)
    {
        return Results.BadRequest();
    }

    return Results.Ok("Post atualizado com sucesso.");
})
.WithTags("Post Endpoints")
.WithOpenApi();

app.MapDelete("post-delete", async (int Id) =>
{
    PostRepository _repository = new PostRepository();
    bool deleted = await _repository.DeletePostAsync(Id);

    if(! deleted)
    {
        return Results.BadRequest();
    }

    return Results.Ok("Registro apagado com sucesso.");
})
.WithTags("Post Endpoints")
.WithOpenApi();

app.Run();

