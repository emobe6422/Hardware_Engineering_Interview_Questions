`timescale 1ns / 1ps


module tb_bit_counter();

    reg clk = 0;
    reg reset = 1;
    wire [3:0] counter;
    
    always #10 clk = ~clk;
    
    bit_counter bit_counter(
        .clk(clk),
        .reset(reset),
        .counter(counter)
    );
    
    initial begin
        #20;   
        reset = 0;
        #120;   
        $finish;
    end
endmodule
