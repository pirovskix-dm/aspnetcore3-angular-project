using ExploringTheCore.Core.Contracts.Repositories;
using ExploringTheCore.Core.Entities;
using System;

namespace ExploringTheCore.TestData.Repositories
{
    public class BlogPostRepository : BaseRepository<BlogPost>, IBlogPostRepository
    {
        public BlogPostRepository()
        {
            InitData();
        }

        private void InitData()
        {
            testData.Add(new BlogPost()
            {
                Id = Guid.NewGuid(),
                Title = "Title one",
                Content = "Content one"
            });

            testData.Add(new BlogPost()
            {
                Id = Guid.NewGuid(),
                Title = "Title two",
                Content = "Content two"
            });

            testData.Add(new BlogPost()
            {
                Id = Guid.NewGuid(),
                Title = "Title three",
                Content = "Content three"
            });
        }
    }
}
