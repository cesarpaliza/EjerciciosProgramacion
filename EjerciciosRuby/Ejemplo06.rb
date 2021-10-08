puts "Recibir como input de entrada un numero de segundos y devolver como resultado su equivalencia en hora, minutos y segundos."

puts "Introduce un en numeros los segundos a convertir"

x = gets.to_i

puts " #{ x / 3600 }:#{ (x % 3600) / 60 }:#{ x % 60 } "