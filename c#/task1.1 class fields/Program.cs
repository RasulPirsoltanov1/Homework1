// 1.1. Bir Product class-ı olsun içində name(product-ın adı)
// , costPirce(maya dəyəri), saledPrice(satış dəyər) field-ləri
// olsun və bir Book class-ı olsun Book class-ı Product class-ından
// inheritance alsın və əlavə olaraq Book class-ında authorName(müəllif adı)
// , pageCount(səhifə sayı) və discountPercent(endirim faizi) adlı field-ları olsun

//1.2.Book class-ında bir GetInfo deyə bir method-u olsun həmin method book-un bütün məlumatlarını ekrana çıxartsın.

//1.3. Book class-ında bir GetDiscountedPrice adlı method olsun
//salePrice(satış qiyməti) və discountPercent(endirim faizi)-ə görə endirimli qiyməti hesablayıb geriyə qaytarsın.

using task1._1_class_fields;

Book newBook = new Book("asdsa","dffg",213,100,543,50);

newBook.GetInfo();

Console.WriteLine("\n after sale precent price: " + newBook.GetDiscountedPrice());
