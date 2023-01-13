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
Article Article3 = new Article(411, "DFG");
Article3.DisplayArticle(); 
#endregion
