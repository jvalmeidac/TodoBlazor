#pragma checksum "C:\DEV\TodoApp\TodoApp\Pages\Todo.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8801c4e2149dfdece33185906021386e3fe0dfa9"
// <auto-generated/>
#pragma warning disable 1591
namespace TodoApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\DEV\TodoApp\TodoApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\DEV\TodoApp\TodoApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\DEV\TodoApp\TodoApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\DEV\TodoApp\TodoApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\DEV\TodoApp\TodoApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\DEV\TodoApp\TodoApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\DEV\TodoApp\TodoApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\DEV\TodoApp\TodoApp\_Imports.razor"
using TodoApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\DEV\TodoApp\TodoApp\_Imports.razor"
using TodoApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\DEV\TodoApp\TodoApp\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\DEV\TodoApp\TodoApp\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\DEV\TodoApp\TodoApp\Pages\Todo.razor"
using TodoApp.Model;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/todo")]
    public partial class Todo : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3 class=\"container\">Todo</h3>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "container");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "span");
            __builder.AddAttribute(5, "type", "text");
            __builder.AddAttribute(6, "class", "btn btn-warning");
            __builder.AddMarkupContent(7, "\r\n        Pendentes ");
            __builder.OpenElement(8, "span");
            __builder.AddAttribute(9, "class", "badge badge-light");
            __builder.AddContent(10, "(");
            __builder.AddContent(11, 
#nullable restore
#line 8 "C:\DEV\TodoApp\TodoApp\Pages\Todo.razor"
                                                    todos.Count(todo => !todo.isDone)

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(12, ")");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n    ");
            __builder.OpenElement(15, "span");
            __builder.AddAttribute(16, "type", "text");
            __builder.AddAttribute(17, "class", "btn btn-success");
            __builder.AddMarkupContent(18, "\r\n        Concluídas ");
            __builder.OpenElement(19, "span");
            __builder.AddAttribute(20, "class", "badge badge-light");
            __builder.AddContent(21, "(");
            __builder.AddContent(22, 
#nullable restore
#line 11 "C:\DEV\TodoApp\TodoApp\Pages\Todo.razor"
                                                     todos.Count(todo => todo.isDone)

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(23, ")");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n");
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "class", "container input-group mb-3 mt-3");
            __builder.AddMarkupContent(29, "\r\n    ");
            __builder.OpenElement(30, "input");
            __builder.AddAttribute(31, "type", "text");
            __builder.AddAttribute(32, "class", "form-control");
            __builder.AddAttribute(33, "placeholder", "Título da tarefa");
            __builder.AddAttribute(34, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 15 "C:\DEV\TodoApp\TodoApp\Pages\Todo.razor"
                                                                                  newTodo

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(35, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => newTodo = __value, newTodo));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n    ");
            __builder.OpenElement(37, "div");
            __builder.AddAttribute(38, "class", "input-group-append");
            __builder.AddMarkupContent(39, "\r\n        ");
            __builder.OpenElement(40, "button");
            __builder.AddAttribute(41, "class", "btn btn-outline-primary");
            __builder.AddAttribute(42, "type", "button");
            __builder.AddAttribute(43, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 17 "C:\DEV\TodoApp\TodoApp\Pages\Todo.razor"
                                                                        AddTodo

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(44, "Adicionar");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n");
            __builder.OpenElement(48, "div");
            __builder.AddAttribute(49, "class", "container");
            __builder.AddMarkupContent(50, "\r\n    ");
            __builder.AddMarkupContent(51, "<div class=\"row\">\r\n        <div class=\"col-md-6\">\r\n            <h5>Tarefa:</h5>\r\n        </div>\r\n        <div class=\"col-md-6\">\r\n            <h5>Adicionada em:</h5>\r\n        </div>\r\n    </div>\r\n    ");
            __builder.OpenElement(52, "ul");
            __builder.AddAttribute(53, "class", "list-group input-group mb-3");
            __builder.AddMarkupContent(54, "\r\n");
#nullable restore
#line 30 "C:\DEV\TodoApp\TodoApp\Pages\Todo.razor"
         foreach (var todo in todos)
        {
            if (todo.isDone == false)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(55, "                ");
            __builder.OpenElement(56, "li");
            __builder.AddAttribute(57, "class", "list-group-item border-warning mb-1");
            __builder.AddMarkupContent(58, "\r\n                    ");
            __builder.OpenElement(59, "div");
            __builder.AddAttribute(60, "class", "input-group mb-3");
            __builder.AddMarkupContent(61, "\r\n                        ");
            __builder.OpenElement(62, "div");
            __builder.AddAttribute(63, "class", "input-group-prepend");
            __builder.AddMarkupContent(64, "\r\n                            ");
            __builder.OpenElement(65, "div");
            __builder.AddAttribute(66, "class", "input-group-text");
            __builder.AddMarkupContent(67, "\r\n                                ");
            __builder.OpenElement(68, "input");
            __builder.AddAttribute(69, "type", "checkbox");
            __builder.AddAttribute(70, "aria-label", "Checkbox for following text input");
            __builder.AddAttribute(71, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 38 "C:\DEV\TodoApp\TodoApp\Pages\Todo.razor"
                                              todo.isDone

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(72, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => todo.isDone = __value, todo.isDone));
            __builder.SetUpdatesAttributeName("checked");
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(75, "\r\n                        ");
            __builder.OpenElement(76, "input");
            __builder.AddAttribute(77, "type", "text");
            __builder.AddAttribute(78, "class", "form-control");
            __builder.AddAttribute(79, "aria-label", "Text input with checkbox");
            __builder.AddAttribute(80, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 41 "C:\DEV\TodoApp\TodoApp\Pages\Todo.razor"
                                      todo.Title

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(81, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => todo.Title = __value, todo.Title));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(82, "\r\n                        ");
            __builder.OpenElement(83, "input");
            __builder.AddAttribute(84, "type", "date");
            __builder.AddAttribute(85, "class", "form-control");
            __builder.AddAttribute(86, "aria-label", "Text input with checkbox");
            __builder.AddAttribute(87, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 42 "C:\DEV\TodoApp\TodoApp\Pages\Todo.razor"
                                      todo.AddedIn

#line default
#line hidden
#nullable disable
            , format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(88, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => todo.AddedIn = __value, todo.AddedIn, format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(89, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(90, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(91, "\r\n");
#nullable restore
#line 45 "C:\DEV\TodoApp\TodoApp\Pages\Todo.razor"
            }
            else
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(92, "                ");
            __builder.OpenElement(93, "li");
            __builder.AddAttribute(94, "class", "list-group-item border-success mb-1");
            __builder.AddMarkupContent(95, "\r\n                    ");
            __builder.OpenElement(96, "div");
            __builder.AddAttribute(97, "class", "input-group mb-3");
            __builder.AddMarkupContent(98, "\r\n                        ");
            __builder.OpenElement(99, "div");
            __builder.AddAttribute(100, "class", "input-group-prepend");
            __builder.AddMarkupContent(101, "\r\n                            ");
            __builder.OpenElement(102, "div");
            __builder.AddAttribute(103, "class", "input-group-text");
            __builder.AddMarkupContent(104, "\r\n                                ");
            __builder.OpenElement(105, "input");
            __builder.AddAttribute(106, "type", "checkbox");
            __builder.AddAttribute(107, "aria-label", "Checkbox for following text input");
            __builder.AddAttribute(108, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 52 "C:\DEV\TodoApp\TodoApp\Pages\Todo.razor"
                                              todo.isDone

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(109, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => todo.isDone = __value, todo.isDone));
            __builder.SetUpdatesAttributeName("checked");
            __builder.CloseElement();
            __builder.AddMarkupContent(110, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(111, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(112, "\r\n                        ");
            __builder.OpenElement(113, "input");
            __builder.AddAttribute(114, "type", "text");
            __builder.AddAttribute(115, "class", "form-control");
            __builder.AddAttribute(116, "aria-label", "Text input with checkbox");
            __builder.AddAttribute(117, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 55 "C:\DEV\TodoApp\TodoApp\Pages\Todo.razor"
                                      todo.Title

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(118, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => todo.Title = __value, todo.Title));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(119, "\r\n                        ");
            __builder.OpenElement(120, "input");
            __builder.AddAttribute(121, "type", "date");
            __builder.AddAttribute(122, "class", "form-control");
            __builder.AddAttribute(123, "aria-label", "Text input with checkbox");
            __builder.AddAttribute(124, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 56 "C:\DEV\TodoApp\TodoApp\Pages\Todo.razor"
                                      todo.AddedIn

#line default
#line hidden
#nullable disable
            , format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(125, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => todo.AddedIn = __value, todo.AddedIn, format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(126, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(127, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(128, "\r\n");
#nullable restore
#line 59 "C:\DEV\TodoApp\TodoApp\Pages\Todo.razor"
            }
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(129, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(130, "\r\n\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 68 "C:\DEV\TodoApp\TodoApp\Pages\Todo.razor"
       

    IList<TodoItem> todos = new List<TodoItem>();
    private string newTodo;

    private void AddTodo()
    {
        if (!string.IsNullOrWhiteSpace(newTodo))
        {
            TodoItem todo = new TodoItem()
            {
                isDone = false,
                Title = newTodo,
                AddedIn = DateTime.Now,
            };
            todos.Add(todo);

            toastService.ShowSuccess($"Tarefa '{newTodo}' Adicionada!", "Sucesso");

            newTodo = string.Empty;
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService toastService { get; set; }
    }
}
#pragma warning restore 1591
