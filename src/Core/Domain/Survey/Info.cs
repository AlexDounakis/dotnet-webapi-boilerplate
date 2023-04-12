using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FSH.WebApi.Domain.Survey;
public class Info
{
    [JsonIgnore]
    public Guid Id { get; set; }
    [JsonIgnore]
    public Guid FormId { get; set; }
    [JsonIgnore]
    public Form Form { get; set; }
    [JsonPropertyName("title")]
    public string Title { get; set; }
    [JsonPropertyName("description")]
    public string Description { get; set; }
    [JsonPropertyName("documentTitle")]
    public string DocumentTitle { get; set; }

    //public Info(Guid id, Guid formId, Form form, string title, string description, string documentTitle)
    //{
    //    Id = id;
    //    FormId = formId;
    //    Form = form;
    //    Title = title;
    //    Description = description;
    //    DocumentTitle = documentTitle;
    //}
}
