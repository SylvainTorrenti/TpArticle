using TpArticle;

#region Article1 with full constructor
Article Art1 = new Article(855, "ATA", 100, 120);
Art1.DisplayArticle();
#endregion
#region Article2 with default constructor
Article Art2 = new Article();
Art2.Reference = 888;
Art2.Designation = "FFF";
Art2.PriceET = 100;
Art2.CalculateVAT();
Art2.DisplayArticle();
#endregion
#region Article3 with Reference and Designation
Article Art3 = new Article(411, "DFG");
Art3.PriceET = 78;
Art3.CalculateVAT();
Art3.DisplayArticle();
#endregion
#region Article4 with copy constructor
Article Article4 = new Article(Art3);
Article4.DisplayArticle(); 
#endregion
