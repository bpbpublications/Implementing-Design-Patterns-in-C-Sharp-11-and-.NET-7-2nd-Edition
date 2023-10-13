namespace BPBDesignPatternsChapter15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User userOne = new User();
            userOne.FullName = "User one";

            User userTwo = new User();
            userTwo.FullName = "User two";

            User userThree = new User();
            userThree.FullName = "User three";

            Blog blog = new Blog();
            blog.Attach(userOne);
            blog.Attach(userTwo);
            blog.Attach(userThree);

            Post post = new Post();
            post.Title = "New post";
            post.Description = "New post description";
            post.PublicationTime = DateTime.UtcNow;

            blog.AddPost(post);

            Console.ReadLine();
        }
    }
}