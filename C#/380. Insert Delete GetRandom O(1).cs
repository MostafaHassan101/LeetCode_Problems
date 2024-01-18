// 380. Insert Delete GetRandom O(1)

public class RandomizedSet {
    private Dictionary<int, int> dict;
    private List<int> list;
    private Random rand;
    /** Initialize your data structure here. */
    public RandomizedSet() {
        dict = new Dictionary<int, int>();
        list = new List<int>();
        rand = new Random();
    }
    
    /** Inserts a value to the set. Returns true if the set did not already contain the specified element. */
    public bool Insert(int val) {
        if(dict.ContainsKey(val)) return false;
        dict.Add(val, list.Count);
        list.Add(val);
        return true;
    }
    
    /** Removes a value from the set. Returns true if the set contained the specified element. */
    public bool Remove(int val) {
        if(!dict.ContainsKey(val)) return false;
        int index = dict[val];
        dict.Remove(val);
        if(index != list.Count - 1){
            int last = list[list.Count - 1];
            list[index] = last;
            dict[last] = index;
        }
        list.RemoveAt(list.Count - 1);
        return true;
    }
    
    /** Get a random element from the set. */
    public int GetRandom() {
        return list[rand.Next(list.Count)];
    }
}