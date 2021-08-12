using System;

namespace Devpro.Examples.WebApiAllAutomated.WebApi.Dto
{
    public class PodcastDto
    {
        public string Id { get; set; }

        public string Title { get; set; }

        public string Author { get; set; }

        public DateTime Duration { get; set; }

        public string Summary { get; set; }

        public DateTime PublishedAt { get; set; }
    }
}
