using System.Text.Json.Serialization;

namespace FSH.WebApi.Domain.Survey;
public class Item
{
    [JsonIgnore]
    public Guid Id { get; set; }
    [JsonIgnore]
    public Guid FormId { get; set; }
    [JsonIgnore]
    public Form Form { get; set; }
    [JsonPropertyName("itemId")]
    public string ItemId { get; set; }
    [JsonPropertyName("title")]
    public string? Title { get; set; }

    //public ImageItem imageItem { get; set; }
    //public QuestionItem questionItem { get; set; }

    //public Item(Guid id, Guid formId, Form form, string itemId, string? title)
    //{
    //    Id = id;
    //    FormId = formId;
    //    Form = form;
    //    ItemId = itemId;
    //    Title = title;
    //}
}