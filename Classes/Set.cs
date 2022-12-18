using System.Collections;

namespace DataStructures.Classes
{
    public class Set<T>: IEnumerable<T>
    {
        private List<T> items = new List<T>();
        private int count;
        public void Add(T item){
            if(!items.Contains(item)){
                items.Add(item);
                count++;
            }
        }
        public void Delete(T item){
            if(items.Contains(item)){
                items.Remove(item);
                count--;
            }
        }
        public static Set<T> Union(Set<T> set1, Set<T> set2){
            Set<T> result = new Set<T>();
            List<T> resultItems = new List<T>();
            if(set1 != null && set2 != null){
                if(set1.Count > 0){
                    resultItems.AddRange(new List<T>(set1.items));
                }
                if(set2.Count > 0){
                    resultItems.AddRange(new List<T>(set2.items));
                }
                resultItems = resultItems.Distinct().ToList();
                foreach(var item in resultItems){
                    result.Add(item);
                }
            }
            return result;
        }
        public static Set<T> Intersection(Set<T> set1, Set<T> set2){
            Set<T> result = new Set<T>();
            if(set1 != null && set2 != null){
                if(set1.Count > set2.Count){
                    foreach(var item in set2.items){
                        if(set1.items.Contains(item)) result.Add(item);
                    }
                } else {
                    foreach(var item in set1.items){
                        if(set2.items.Contains(item)) result.Add(item);
                    }
                }
            }
            return result;
        }
        public static Set<T> Difference(Set<T> set1, Set<T> set2){
            Set<T> result = new Set<T>();
            List<T> resultItems = new List<T>();
            if(set1 != null && set2 != null){
                foreach(var item in set1.items){
                        if(!set2.items.Contains(item)) resultItems.Add(item);
                }
                foreach(var item in set2.items){
                        if(!set1.items.Contains(item)) resultItems.Add(item);
                }
                resultItems = resultItems.Distinct().ToList();
                foreach(var item in resultItems){
                    result.Add(item);
                }
            }
            return result;
        }
        public static bool Subset(Set<T> set1, Set<T> set2){
            bool result = false;
            if(set1 != null && set2 != null){
                result = set1.items.All(x => set2.items.Contains(x));
            }
            return result;
        }
        public int Count{get {return count;}}
        public bool IsEmpty{get {return count == 0;}}
        public void Clear(){
            items.Clear();
            count = 0;
        }
        public IEnumerator<T> GetEnumerator(){
            return items.GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator(){
            return items.GetEnumerator();
        }
    }
}