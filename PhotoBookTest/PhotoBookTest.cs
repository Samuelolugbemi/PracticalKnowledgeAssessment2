using System;

namespace PhotoBookTest
{
    class PhotoBookTest
    {
        static void Main(string[] args)
        {
            PhotoBook photoBook = new PhotoBook();
            PhotoBook photoBook2 = new PhotoBook(24);
            BigPhotoBook bigPhotoBook = new BigPhotoBook();

            Console.WriteLine($"Number of pages on the default photo book: {photoBook.GetNumberPages()}");
            Console.WriteLine($"Number of pages on the photo book with specified page number: {photoBook2.GetNumberPages()}");
            Console.WriteLine($"Number of pages in the large photo book: {bigPhotoBook.GetNumberPages()}");

        }
    }
}
