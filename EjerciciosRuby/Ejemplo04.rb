puts "Imprimir las tablas de multiplicar del 1 al 10."

a = 10
1.upto(10) { |x| a.times { |y| puts " #{x} x #{y += 1} = #{x*y} " } }