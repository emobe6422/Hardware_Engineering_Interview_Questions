`timescale 1ns / 1ps

module bit_counter(
    input wire clk,
    input wire reset,
    output reg [3:0] counter 
    );
    
    always @(posedge clk) begin
        if (reset) begin
            counter <= 0;
        end else begin
            counter <= counter + 1;
        end
    end
endmodule
