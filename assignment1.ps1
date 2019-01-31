function Divide()  #function for division
{
# Exception Handling
try{


$ans = $a/$b  #dividing the numbers
 return $ans  #returning the value
 
}
catch [DivideByZeroException]
{
 Write-Host "Divide by zero exception"
}
}

try
{
 Write-Host 'Enter a number'
[int]$a = Read-Host             #user input
Write-Host 'Enter a number'
[int]$b = Read-Host             #user input

$num =  divide $a $b           #calling the function and receving the value from the function
Write-Host $num
}

#handlling other exception if occurs
catch 
{
 Write-Host "Exception"
 Write-Host $_.Exception.Message
}
