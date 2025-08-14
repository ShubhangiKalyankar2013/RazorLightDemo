// See https://aka.ms/new-console-template for more information
using RazorLightDemo;
using RazorLightDemo.Models;

//Console.WriteLine("Hello, World!");

var emailRenderer = new EmailRenderer();
var emailSender = new EmailSender();

var  emailText = await emailRenderer.RenderEmailAsync("WelcomeEmail", new WelcomeEmailModel
{
    UserName = "John Doe",
    ActivationLink = "https://example.com/activate?token=123456"
});

var emailText2 = await emailRenderer.RenderEmailAsync("CreateConciergeItemNewEmailTemplate", new CreateConciergeItemEmailModel
{
    ConciergeItemId = 123,
    SummaryID = 456,
    MemberName = "Jane Smith",
    DateCreated = DateTime.Now,
    ClientName = "Acme Corp",
    ProgrammeName = "Premium Support",
    ConciergeItemLink = "https://example.com/concierge/item/123",
    SummaryLink = "https://example.com/summary/456",
    ConciergeItemDetails = "Details about the concierge item.",
    SummaryNotes = "Summary notes for the concierge item."
});

emailSender.SendEmail("shubhangi.s52@gmail.com", "Test CSHTML email",emailText2);
//emailSender.SendEmail("shubhangikalyankar@tengroup.com", "Test CSHTML email", emailText);