namespace task02
{
    static class Program
    {
        private static void Main()
        {
            var classRoom = new ClassRoom(new Pupil[] { new ExcelentPupil(), new GoodPupil(), new GoodPupil(), new BadPupil() });
            foreach(var pupil in classRoom.Pupils)
            {
                pupil.Study();
                pupil.Read();
                pupil.Write();
                pupil.Relax();
            }
        }
    }
}
