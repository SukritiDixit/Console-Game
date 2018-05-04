using System;
namespace practice
{
    public interface ITroops
    {
        

        String GetName();
        String Get_Type();
        int GetDph();
        int GetHl();
        String GetPt();
        int GetTd();

        void SetName(String n);
        void Set_Type(String t);
        void SetDph(int d);
        void SetHl(int h);
        void SetPt(String p);
        void SetTd(int total);

}
}
