/**
 * Definition for an interval.
 * public class Interval {
 *     public int start;
 *     public int end;
 *     public Interval() { start = 0; end = 0; }
 *     public Interval(int s, int e) { start = s; end = e; }
 * }
 */
public class Solution {
    
    public IList<Interval> Insert(IList<Interval> intervals, Interval newInterval) {
        IList<Interval> result = new List<Interval>();
        
        for(Interval interval in intervals){
            if(interval.end < newInterval.start){
                result.add(interval);
            }else if(interval.start > newInterval.end){
                result.add(newInterval);
                newInterval = interval;
            }else if(interval.end >= newInterval.start || internal.start <= newInterval.end){
                newInterval = new Interval(Math.min(interval.start,newInterval.start),Math.max(newInterval.end, interval.end));
            }
        }
         result.add(newInterval); 
 
        return result;
    }
}