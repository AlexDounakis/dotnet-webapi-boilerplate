using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FSH.WebApi.Domain.Survey;
public class Settings
{
    [JsonIgnore]
    public Guid Id { get; set; }

    //public QuizSettings quizSettings { get; set; }
    [JsonIgnore]
    public Guid FormId { get; set; }
    [JsonIgnore]
    public Form Form { get; set; }
    //public QuizSettings quizSettings { get; set; }
}
