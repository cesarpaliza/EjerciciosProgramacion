puts "Determinar si un número ingresado por el usuario es divisible entre 17 o no."
puts "Dijite un numero porfavor"
input = gets.to_i

def calcular (a)
  result = a % 17 == 0
  if result
    puts "Si es divisible por 17"
  else
    puts "No es divisible por 17"
  end
end

calcular input