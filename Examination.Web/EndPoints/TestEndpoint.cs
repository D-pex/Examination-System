using Examination.Core.Requests;
using Examination.Services.Exceptions;

namespace Examination.Web.EndPoints;

public static class TestEndpoints
{
    public static void MapTestEndpoints(this IEndpointRouteBuilder app)
    {
        var group = app.MapGroup("/tests");

        
        group.MapPost("/", (TestService service, CreateTestRequest request) =>
        {
            try
            {
                return Results.Ok(service.CreateTest(request));
            }
            catch (ConflictException ex)
            {
                return Results.BadRequest(ex.Message);
            }
        });
        
        group.MapGet("/", (TestService service) =>
        {
            try
            {
                return Results.Ok(service.GetPublishedTests());
            }
            catch (ConflictException ex)
            {
                return Results.BadRequest(ex.Message);
            }
        });
        
        group.MapPut("/{id}/publish", (TestService service, int id) =>
        {
            try
            {
                service.PublishTest(id);
                return Results.Ok("Test published successfully");
            }
            catch (ConflictException ex)
            {
                return Results.BadRequest(ex.Message);
            }
        });
    }
}