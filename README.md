# Coding Assessment

## You are required to create a single web page to display the product details. It includes two parts:

## - Create a RESTful API to return the attached JSON

## - Create a web page to call your API, parse the data and display the product details

## - It should take no more than 2 hours to complete.

## - If you consider yourself as a backend developer, you can focus on requirement #1 (expect

## more thorough); if you are frontend developer, you can focus on requirement #2 (expect

## more thorough); if you are full stack, you are expected to try both.

## - By no means the requirements are fully completed from different aspects, but that’s what

## we are checking for your coding skills, coding style, your sound judgments & decisions on

## how to move forward, how to deal with difficulties and ambiguities.

## 1. Create a RESTful API using C#, and return the JSON data attached.

## - this API will require authentication, you can define temporary user name / pwd as token

## and hardcode the validation.

## - Require request Id = 385

## - Return the JSON in the attachment, you can hardcode it

## - Properly handle different status code

## - Support paging would be a plus

## - Unit test would be a plus

## 2. Create a web page component to display the data you return from the API you created in

## requirement #1, prefer technology React.js (you may use your favorite technology)

## - Implement your logic how to call your API

## - Proper handle exception if API failed.

## - Create React component or function to display the product details coming back from your

## API

## - Properties to display: all different labels with values, for example:

"label": "Lookup State",
"stateCode": "CA",
"stateDesc": "California"

## In the web page, it should display like this:

## Lookup State: CA

## - Other properties required to display: all Description, ABV, Proof, Liters, Item and Item

## properties.

## - Implement your web page with good responsiveness.

## - Proper handle empty data

## - Unit test would be a plus


## Note : For frontend dev, you can assume the JSON data already given (as proper, or you can

## hardcode it as response), and you may ignore the API part.

## 3. Timeline: Please complete your coding in 3 - 4 days after you receive the requirement email.

## 4. Submit:

## - You can send your code through email (only the source code, please)

## - Or you can check in to github and share the githhub link with us

## - Send screenshots with the running web page

## - How do you deal with difficulties and ambiguities

## Good Luck!

# Attachment

## JSON Data:

```
{
"rowidObject": "385 ",
"label": "Corporate MDM ID - 101360",
"ExDoNotUse": "N",
"ExBarrel": "N",
"ExUPC": "999999999999",
"ExSCC": "99999999999999",
"ExCorpMDMID": "101360",
"ExRefOnly": "N",
"ExProductSKU_ExUnitOfMeasure_1_rowidObject": "20797 ",
"ExProductSKU_rowidObject": "300126 ",
"ExRefProduct": {
"ExVntgCrp": "0",
"ExProof": ".00",
"ExItemLife": "0",
"ExABV": ".00",
"ExDscrptnFull": "Clos Du Bois Merlot Wnmkr",
"ExCrpCrtfd": "N",
"ExVntgSnstvCrp": "N",
"ExDscrptn": "Clos Du Bois Merlot Wnmkr",
"ExCrpClass": {
"rowidObject": "1 ",
"label": "Lookup Product Corporate Class",
"ExCorporateClassDesc": "High Wine (>14.5%)",
"ExCrpClassID": "High Wine (>14.5%)"
},
"ExTempProtectionFlg": "N",
"ExUnitOfMeasure": {
"ExCasesPerPallet": "0",
"ExLiters": "6.0000000",
"ExCaseWidth": "1.0000",
"ExCaseHeight": "1.0000",
"ExGallonage": "1.5850320",
"ExCaseWeight": ".00",
"ExCaseLength": "1.0000",
"ExCasesPerLayer": "0",
"ExTrueBtlsPerCase": "1",
"ExCaseEqvlnt": "1.000",
"ExBttlCase": "1",
"ExMultiPack": "0"
},
"ExProductContainer": {
"link": [],
"firstRecord": 1 ,
"pageSize": 100 ,
"searchToken": "multi",
"item": [
{
"rowidObject": "295733 ",
"label": "SKU to Container Relationship",
"ExPalletType": "Standard (43.1In - 65In)",
"ExCntnrType": {
"rowidObject": "12 ",
"label": "Lookup Product Container Type",
"ExCntnrTypeDesc": "Other",
"ExCntnrTypeID": "Other"
},
"ExClosureTyp": {
"rowidObject": "3 ",
"label": "Lookup Product Closure Type",
"ExClsrTypeDesc": "Cork",
"ExClsrTypId": "Cork"
},
"ExSzDscrptr": {
"rowidObject": "285 ",
"label": "Lookup Product Size Descriptor",
"ExSizeDesc": "6L",
"ExSzDscrptrID": "6L"
},
"ExProductLabel": {
"link": [],
"firstRecord": 1 ,
"pageSize": 100 ,
"searchToken": "multi",
"item": [
{
"rowidObject": "288511 ",
"label": "Label Container Rel",
"ExColor": {
"rowidObject": "7 ",
"label": "Lookup Product Color",
"ExColorDesc": "Red",
"ExColorID": "Red"
},
"ExLabelNm": "Clos Du Bois Wnmkr Merlot",
"ExRegion": "N/A WINE",
"ExState": {
"rowidObject": "6 ",
"label": "Lookup State",
"stateCode": "CA",
"stateDesc": "California"
},
"ExCountry": {
"rowidObject": "228 ",
"label": "Lookup Country",
"countryCode": "US",
"countryDesc": "United States"
},
"ExProductBrand": {
"link": [],
"firstRecord": 1 ,
"pageSize": 100 ,
"searchToken": "multi",
"item": [
{
"rowidObject": "2554 ",
"label": "Brand Label Relationship",
"ExBrandNm": "Clos Du Bois"
} ] } } ] } } ] }
},
"ExProductAltId": {
"link": [],
"firstRecord": 1 ,
"pageSize": 100 ,
"searchToken": "multi",
"item": [
{
"rowidObject": "1005579 ",
"label": "Product Alternate Indentifier",
"ExAltID": "3829565",
"ExAltIDType": {
"rowidObject": "15 ",
"label": "Lookup Product Alternate ID",
"ExAltIDTypeDesc": "Data Warehouse",
"ExAltIDType": "EDW ID"
}
}
]
}
}
```