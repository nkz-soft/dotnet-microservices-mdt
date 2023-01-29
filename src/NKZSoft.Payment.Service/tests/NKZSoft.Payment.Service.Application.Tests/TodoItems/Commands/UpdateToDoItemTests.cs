using NKZSoft.Payment.Service.Application.TodoItems.Commands.Update;

namespace NKZSoft.Payment.Service.Application.Tests.TodoItems.Commands;

[Collection("QueryCollection")]
public sealed class UpdateToDoItemTests : TestBase
{
    private const string ToDoItemTitle = "UpdateTitle";
    private const string ToDoItemUpdatedTitle = "UpdatedTitle";

    public UpdateToDoItemTests(QueryTestFixture fixture) : base(fixture)
    {
    }

    [Fact]
    public async Task ShouldUpdateTodoItem()
    {
        var createCommand = new CreateToDoItemCommand(ToDoItemTitle, null);
        var createResult = await Mediator.Send(createCommand);

        createResult.Should().NotBeNull();
        createResult.IsSuccess.Should().BeTrue();

        var updateCommand = new UpdateTodoItemCommand(createResult.Value, ToDoItemUpdatedTitle, ToDoItemUpdatedTitle);
        await Mediator.Send(updateCommand);
    }
}
