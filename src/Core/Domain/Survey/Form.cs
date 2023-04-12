using System.Text.Json.Serialization;

namespace FSH.WebApi.Domain.Survey;
public class Form : AuditableEntity
{
    [JsonIgnore]
    public Guid Id { get; set; }

    [JsonPropertyName("formId")]
    public string FormId { get; set; }

    [JsonPropertyName("info")]
    public Info Info { get; set; }

    [JsonPropertyName("settigns")]
    public Settings Settings { get; set; }

    [JsonPropertyName("revisionId")]
    public string RevisionId { get; set; }

    [JsonPropertyName("responderUri")]
    public string ResponderUri { get; set; }

    [JsonPropertyName("items")]
    public List<Item> Items { get; set; }

    //public Form(Guid id, string formId, Info info, Settings settings, string revisionId, string responderUri, List<Item> items)
    //{
    //    Id = id;
    //    FormId = formId;
    //    Info = info;
    //    Settings = settings;
    //    RevisionId = revisionId;
    //    ResponderUri = responderUri;
    //    Items = items;
    //}
}
