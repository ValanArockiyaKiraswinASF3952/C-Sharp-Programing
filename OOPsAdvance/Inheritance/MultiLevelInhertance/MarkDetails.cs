namespace MultiLevelInhertance
{
    public interface IMarkDetails
    {
        //no field
         int Physics { get; set; }  //property declaration only allowed
         int Maths { get; set; }
         int Chemistry { get; set; }
         int Total { get; set; }
         double Average { get; set; }
         //no constructor and object
        void GetMark(int Physics,int Maths,int Chemistry);
        void Calculate();  //method declare only allowed

        void ShowMark();
    }
}