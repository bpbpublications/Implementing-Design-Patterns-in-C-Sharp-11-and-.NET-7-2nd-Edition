using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.JavaScript;
using System.Text;
using System.Threading.Tasks;

namespace BPBDesignPatternsChapter15
{
    public class Blog : ISubject
    {
        private Post _post = new Post();
        private List<IObserver> observers = new List<IObserver>();
        public void Attach(IObserver observer)
        {
            observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var observer in observers)
            {
                observer.Update(_post);
            }
        }

        public void AddPost(Post post)
        {
            _post = post;
            Notify();
        }
    }
}
