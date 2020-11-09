namespace PhotoBookTest
{
    public class PhotoBook
    {
        private int numPages;
        public PhotoBook()
        {
            this.numPages = 16;
        }
        public PhotoBook(int numPages)
        {
            this.numPages = numPages;
        }

        public int GetNumberPages()
        {
            return numPages;
        }
    }
}