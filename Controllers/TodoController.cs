using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using todo.Models;
using todo.Views;

namespace todo.Controllers;

[ApiController]

public class TodoController : ControllerBase
{
    [HttpGet("/api/todo")]
    public List<Todo> GetTodos()
    {
        return TodoView.MyTodos;
    }
}
