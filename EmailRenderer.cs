using RazorLight;

namespace RazorLightDemo;
public class EmailRenderer
{
    private readonly RazorLight.RazorLightEngine _engine;

    public EmailRenderer()
    {
        string templatesRoot = Path.Combine(Directory.GetCurrentDirectory(), "EmailTemplates");

        string templateroot = Path.Combine($"{AppDomain.CurrentDomain.BaseDirectory}", "EmailTemplates");


        _engine = new RazorLightEngineBuilder()
               .UseFileSystemProject(templatesRoot)
               .UseMemoryCachingProvider()
               .Build();
    }

    public async Task<string> RenderEmailAsync<T>(string templateName, T model)
    {
        try
        {
            string result = await _engine.CompileRenderAsync(templateName, model);
            return result;
        }
        catch (Exception ex)
        {
            // Handle exceptions (e.g., log them)
            throw new InvalidOperationException($"Error rendering email template '{templateName}': {ex.Message}", ex);
        }
    }
}
