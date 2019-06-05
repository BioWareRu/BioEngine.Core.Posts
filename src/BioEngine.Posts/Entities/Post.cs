using System.ComponentModel.DataAnnotations.Schema;
using BioEngine.Core.Abstractions;
using BioEngine.Core.DB;
using BioEngine.Core.Entities;
using BioEngine.Posts.Routing;

namespace BioEngine.Posts.Entities
{
    [TypedEntity("post")]
    public class Post : ContentItem<PostData>
    {
        public bool IsPinned { get; set; } = false;
        public override string TypeTitle { get; } = "Пост";
        [NotMapped] public override string PublicRouteName { get; set; } = BioEnginePostsRoutes.Post;
    }

    public class PostData : ITypedData
    {
    }
}
