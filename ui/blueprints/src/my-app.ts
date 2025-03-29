import { css, html, LitElement } from "lit";
import { customElement } from "lit/decorators.js";
import "./components/text-adventure-game";

@customElement("my-app")
export class MyApp extends LitElement {
  static styles = [
    css`
      h1 {
        font-weight: bold;
      }
    `
  ];
  render() {
    return html`
      <h1>App Blueprints</h1>
      <text-adventure-game></text-adventure-game>
    `;
  }

}
