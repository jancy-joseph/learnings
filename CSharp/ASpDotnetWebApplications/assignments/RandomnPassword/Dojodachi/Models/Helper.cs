namespace Dojodachi.Models
{
    public static class Helper
    {
        public static void GameResult(ref djdachi dchi)
        {
            if(dchi.checkGameOver() ==1)
            {
                dchi.mystring = "Congragulations!! You have won!!";
                dchi.showBtnFlag = true;
            }
            else if(dchi.checkGameOver() ==-1)
            {
                dchi.mystring = "Your dojodachi passed away!!";
                dchi.showBtnFlag = true;
            }
            else
            {
                dchi.showBtnFlag = false;
            }
            return;
        }

    }
}